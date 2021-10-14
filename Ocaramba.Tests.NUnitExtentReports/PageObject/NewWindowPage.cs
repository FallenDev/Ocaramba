﻿// <copyright file="NewWindowPage.cs" company="Objectivity Bespoke Software Specialists">
// Copyright (c) Objectivity Bespoke Software Specialists. All rights reserved.
// </copyright>
// <license>
//     The MIT License (MIT)
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// </license>

namespace Ocaramba.Tests.NUnitExtentReports.PageObjects
{
    using Ocaramba;
    using Ocaramba.Extensions;
    using Ocaramba.Tests.PageObjects;
    using Ocaramba.Types;

    public class NewWindowPage : ProjectPageBase
    {
        private readonly ElementLocator
    newWindowPageLocator = new ElementLocator(Locator.CssSelector, "h3");

        public NewWindowPage(DriverContext driverContext)
            : base(driverContext)
        {
        }

        public bool IsNewWindowH3TextVisible(string text)
        {
            return this.Driver.GetElement(this.newWindowPageLocator).IsElementTextEqualsToExpected(text);
        }

        public bool IsPageTile(string title)
        {
            return this.Driver.IsPageTitle(title, 2);
        }
    }
}
