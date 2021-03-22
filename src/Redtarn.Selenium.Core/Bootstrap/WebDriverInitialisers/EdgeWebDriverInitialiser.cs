﻿// <copyright file="EdgeWebDriverInitialiser.cs" company="Red Tarn Technology Ltd">
// Copyright (c) Red Tarn Technology Ltd. All rights reserved.
// </copyright>

using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace RedTarn.Selenium.Core.Bootstrap.WebDriverInitialisers
{
    /// <summary>
    /// The Microsoft Edge web driver initialiser.
    /// </summary>
    public class EdgeWebDriverInitialiser : BaseWebDriverInitialiser
    {
        /// <summary>
        /// Initialise the web driver as a desktop device.
        /// </summary>
        /// <returns>The web driver.</returns>
        protected override IWebDriver InitialiseDesktop()
        {
            var webDriver = new EdgeDriver(Environment.CurrentDirectory);

            webDriver.Manage().Window.Size = new Size(1280, 1024);

            return webDriver;
        }

        /// <summary>
        /// Initialise the web driver as a tablet device.
        /// </summary>
        /// <returns>The web driver.</returns>
        protected override IWebDriver InitialiseTablet()
        {
            var webDriver = new EdgeDriver(Environment.CurrentDirectory);

            webDriver.Manage().Window.Size = new Size(768, 1024);

            return webDriver;
        }

        /// <summary>
        /// Initialise the web driver as a phone device.
        /// </summary>
        /// <returns>The web driver.</returns>
        protected override IWebDriver InitialisePhone()
        {
            var webDriver = new EdgeDriver(Environment.CurrentDirectory);

            webDriver.Manage().Window.Size = new Size(414, 736);

            return webDriver;
        }
    }
}
