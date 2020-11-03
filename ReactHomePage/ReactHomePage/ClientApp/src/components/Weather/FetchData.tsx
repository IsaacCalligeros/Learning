import React, { Component, useEffect, useState } from "react";
import axiosInstance from "../../axiosInstance";
import WeatherTypes from "./types";

const FetchData = () => {
  const [loading, setLoading] = useState(true);
  const [forecasts, setForecasts] = useState<WeatherTypes.forecast[]>([]);

  useEffect(() => {
    async function populateWeatherData() {
      await axiosInstance.get("/weatherforecast").then((res) => {
        setForecasts(res.data);
        setLoading(loading);
      });
    }
  }, []);

  return loading ? (
    <p>
      <em>Loading...</em>
    </p>
  ) : (
    <table className="table table-striped" aria-labelledby="tabelLabel">
      <thead>
        <tr>
          <th>Date</th>
          <th>Temp. (C)</th>
          <th>Temp. (F)</th>
          <th>Summary</th>
        </tr>
      </thead>
      <tbody>
        {forecasts.map((forecast) => (
          <tr key={forecast.summary}>
            <td>{forecast.date}</td>
            <td>{forecast.temperatureC}</td>
            <td>{forecast.temperatureF}</td>
            <td>{forecast.summary}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export { FetchData };
