/*
 * Weather API
 *
 * This is a sample weather API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: deepak.h.sharma@capgemini.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WeatherApi.Attributes;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class WeatherApiController : Controller
    { 
        /// <summary>
        /// Get Weather By Zip Code
        /// </summary>
        /// <remarks>Get weather by Zip Code</remarks>
        /// <param name="zipcode">zipcode</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid value</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Unexpected Error has occurred</response>
        [HttpGet]
        [Route("/api/weather/{zipcode}")]
        [ValidateModelState]
        [SwaggerOperation("GetWeatherByZipCode")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Forecast>), description: "successful operation")]
        [SwaggerResponse(statusCode: 500, type: typeof(Error), description: "Unexpected Error has occurred")]
        public virtual IActionResult GetWeatherByZipCode([FromRoute][Required]int? zipcode)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Forecast>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Error));

            List<Forecast> forecastList = new List<Forecast>();

            Forecast f1 = new Forecast();
            f1.Day = "Monday";
            f1.High = 80;
            f1.Low = 65;
            f1.Zipcode = zipcode;
            f1.Detail = "Partially Cloudy";
            forecastList.Add(f1);

            Forecast f2 = new Forecast();
            f2.Day = "Tuesday";
            f2.High = 90;
            f2.Low = 70;
            f2.Zipcode = zipcode;
            f2.Detail = "Partially Rainy";
            forecastList.Add(f2);

            return new ObjectResult(forecastList);
        }
    }
}