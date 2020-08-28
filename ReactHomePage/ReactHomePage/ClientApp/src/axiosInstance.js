import React, { useState } from "react";
import axios from "axios";
import authService from "./components/api-authorization/AuthorizeService";


// const token = "";

  const getToken = async () => {
    await authService.getAccessToken().then((res) => {
      return res
    });
  };

  const instance = axios.create({
    baseURL: "https://localhost:5001",
  });

  instance.interceptors.request.use(
    async config => {
      const token = await authService.getAccessToken();
      config.headers = { 
        'Authorization': `Bearer ${token}`,
        'Accept': 'application/json',
        'Content-Type': 'application/x-www-form-urlencoded'
      }
      return config;
    },
    error => {
      Promise.reject(error)
  });

  // console.log(getToken());

  // instance.defaults.headers.common["Authorization"] = !token
  //   ? {}
  //   : { Authorization: `Bearer ${token}` };

export default instance;



