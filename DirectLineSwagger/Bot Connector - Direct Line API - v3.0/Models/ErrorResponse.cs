﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using ConsoleApplication2.Models;

namespace ConsoleApplication2.Models
{
    public partial class ErrorResponse
    {
        private Error _error;
        
        /// <summary>
        /// Optional. Error message
        /// </summary>
        public Error Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}