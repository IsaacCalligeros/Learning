import React, { Component, useEffect, useState } from "react";
import axiosInstance from "../../axiosInstance";
import { ASXCompanies, NewsDto } from "../../models/models";
import TextField from "@material-ui/core/TextField";
import _ from "lodash";
import "../../CSS/news.scss";

const EquityList = () => {
  const [loading, setLoading] = useState(true);
  const [asxCompanies, setAsxCompanies] = useState<ASXCompanies[] | undefined>(undefined);
  const [searchTerm, setSearchTerm] = useState("");
  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setSearchTerm(event.target.value);
  };

  useEffect(() => {
    axiosInstance
      .get("api/equity/GetAsxCompanies", {
        params: {
          searchTerm: searchTerm,
        },
      })
      .then((res) => {
        setAsxCompanies(res.data);
        setLoading(false);
      });
  }, [searchTerm]);

  return loading ? (
    <p>
      <em>Loading...</em>
    </p>
  ) : (
    <>
      <TextField
        id="outlined-name"
        className="search-field"
        label="searchTerm"
        value={searchTerm}
        onChange={handleChange}
        variant="outlined"
      />

      <table className="table table-striped" aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Company</th>
            <th>Industry</th>
            <th>Ticker</th>
            <th>Listing date</th>
          </tr>
        </thead>
        <tbody>
          {asxCompanies?.map((company, idx) => (
            <tr key={idx}>
              <td>{company.company}</td>
              <td>{company.industry}</td>
              <td>{company.ticker}</td>
              <td>{company.listingDate}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
};

export { EquityList };
