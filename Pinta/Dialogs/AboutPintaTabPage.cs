// AboutPintaTabPage.cs
//
// Author:
//   Viktoria Dudka (viktoriad@remobjects.com)
//
// Copyright (c) 2009 RemObjects Software
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using System;
using Gtk;
using Pinta.Core;

namespace Pinta
{
	internal class AboutPintaTabPage : VBox
	{
		public AboutPintaTabPage ()
		{
			Label label = new Label ();
			label.Selectable = true;
			label.Markup = String.Format (
			    "<b>{0}</b>\n    {1}",
			    Translations.GetString ("Version"),
			    PintaCore.ApplicationVersion);

			HBox hBoxVersion = new HBox ();
			hBoxVersion.PackStart (label, false, false, 5);
			this.PackStart (hBoxVersion, false, true, 5);

			label = new Label ();
			label.Markup = string.Format ("<b>{0}</b>\n    {1}", Translations.GetString ("License"), Translations.GetString ("Released under the MIT X11 License."));
			HBox hBoxLicense = new HBox ();
			hBoxLicense.PackStart (label, false, false, 5);
			this.PackStart (hBoxLicense, false, true, 5);

			label = new Label ();
			label.Markup = string.Format ("<b>{0}</b>\n    (c) 2010-2022 {1}", Translations.GetString ("Copyright"), Translations.GetString ("by Pinta contributors"));
			HBox hBoxCopyright = new HBox ();
			hBoxCopyright.PackStart (label, false, false, 5);
			this.PackStart (hBoxCopyright, false, true, 5);

			this.ShowAll ();
		}
	}
}
