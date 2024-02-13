﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using NUnit.Framework;
using Uno.UITest.Helpers;
using Uno.UITest.Helpers.Queries;
using Uno.UITests.Helpers;


namespace Uno.Gallery.UITests
{
	public class Given_AutoSuggestBox : TestBase
	{
		[Test]
		public void AutoSuggestBox_Default()
		{
			NavigateToSample("AutoSuggestBox", "Fluent");
			//TakeScreenshot("Before Text");
			var AutoSuggest = new QueryEx(x => x.All().Marked("fluent_AutoSuggestBox"));
			
			AutoSuggest.EnterText("PasswordBox");
			bool isSuggestionListOpen = AutoSuggest.GetDependencyPropertyValue<bool>("IsSuggestionListOpen");
			Assert.IsTrue(isSuggestionListOpen, "Suggestion list is open");
			Assert.AreEqual("PasswordBox", AutoSuggest.GetDependencyPropertyValue<String>("Text"));

			AutoSuggest.ClearText();
			AutoSuggest.EnterText("Button");
			Assert.IsTrue(isSuggestionListOpen, "Suggestion list is open");
			Assert.AreEqual("Button", AutoSuggest.GetDependencyPropertyValue<String>("Text"));

			AutoSuggest.ClearText();
			AutoSuggest.EnterText("RadioButton");
			Assert.IsTrue(isSuggestionListOpen, "Suggestion list is open");
			Assert.AreEqual("RadioButton", AutoSuggest.GetDependencyPropertyValue<String>("Text"));

			AutoSuggest.ClearText();
			Assert.AreEqual("", AutoSuggest.GetDependencyPropertyValue<String>("Text"));
			Assert.IsTrue(isSuggestionListOpen, "Suggestion list is open");


		}

		[Test]
		public void AutoSuggestBox_Default_Text()
		{
			NavigateToSample("AutoSuggestBox", "Fluent");
			var AutoSuggest_Text = new QueryEx(x => x.All().Marked("fluent_AutoSuggestBox_WithText"));

			AutoSuggest_Text.EnterText("PasswordBox");
			bool isSuggestionListOpen_Text = AutoSuggest_Text.GetDependencyPropertyValue<bool>("IsSuggestionListOpen");
			Assert.IsTrue(isSuggestionListOpen_Text, "Suggestion list is open");
			Assert.AreEqual("PasswordBox", AutoSuggest_Text.GetDependencyPropertyValue<String>("Text"));

			AutoSuggest_Text.ClearText();
			AutoSuggest_Text.EnterText("Button");
			Assert.IsTrue(isSuggestionListOpen_Text, "Suggestion list is open");
			Assert.AreEqual("Button", AutoSuggest_Text.GetDependencyPropertyValue<String>("Text"));

			AutoSuggest_Text.ClearText();
			AutoSuggest_Text.EnterText("RadioButton");
			Assert.IsTrue(isSuggestionListOpen_Text, "Suggestion list is open");
			Assert.AreEqual("RadioButton", AutoSuggest_Text.GetDependencyPropertyValue<String>("Text"));

			AutoSuggest_Text.ClearText();
			Assert.AreEqual("", AutoSuggest_Text.GetDependencyPropertyValue<String>("Text"));
			Assert.IsTrue(isSuggestionListOpen_Text, "Suggestion list is open");

		}
	}
	
}
