﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using System.Xml.Linq;
using System.Xml.Schema;
using System.IO;
using System.Xml;
using Xunit;
using System.Diagnostics;

namespace Twilio.TwiML.Tests
{
	public class DialTests : TestBase
	{
		[Fact]
		public void Can_Generate_Dial_Conference_And_Attributes()
		{
			var response = new TwilioResponse();
			response.DialConference("room1", new { muted = true, beep = false, waitUrl = "wait.xml", waitMethod = "GET" });

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_Conference_And_Attributes_And_Dial_Attributes()
		{
			var response = new TwilioResponse();
			response.DialConference("room1",
				new { muted = true, beep = false, waitUrl = "wait.xml", waitMethod = "GET" },
				new { timeLimit = 30, action = "http://example.com" }
			);

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_Conference()
		{
			var response = new TwilioResponse();
			response.DialConference("room1");

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_Multiple_Numbers()
		{
			var response = new TwilioResponse();
			response.DialNumbers("555-111-1111", "555-222-2222", "555-333-3333");

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Attributes_And_Number_Attributes()
		{
			var response = new TwilioResponse();
			response.Dial("555-111-2222",
				new { action = "dial.xml", method = "GET", timeout = "30", hangupOnStar = "true", timeLimit = "1000", callerId = "555-111-2222" },
				new { url = "whisper.xml", sendDigits = 1234 }
			);

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Attributes()
		{
			var response = new TwilioResponse();
			response.Dial("555-111-2222", new { action = "dial.xml", method = "GET", timeout = "30", hangupOnStar = "true", timeLimit = "1000", callerId = "555-111-2222" });

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial()
		{
			var response = new TwilioResponse();
			response.Dial("555-111-2222");

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Number_Object_Param()
		{
			var response = new TwilioResponse();
			response.Dial(new Number("555-111-2222"));

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Conf_Object_Param()
		{
			var response = new TwilioResponse();
			response.Dial(new Conference("room1"));

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Number_Object_Param_And_Dial_Attributes()
		{
			var response = new TwilioResponse();
			response.Dial(new Number("555-111-2222"), new { action = "dial.xml", method = "GET", timeout = "30", hangupOnStar = "true", timeLimit = "1000", callerId = "555-111-2222" });

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Conf_Object_Param_And_Dial_Attributes()
		{
			var response = new TwilioResponse();
			response.Dial(new Conference("room1"), new { action = "dial.xml", method = "GET", timeout = "30", hangupOnStar = "true", timeLimit = "1000", callerId = "555-111-2222" });
			
			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Client_Noun()
		{
			var response = new TwilioResponse();
			response.Dial(new Client("Jenny"));

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_Multiple_Clients()
		{
			var response = new TwilioResponse();
			response.DialClients("Jenny", "Tommy", "Olive");

			Assert.True(IsValidTwiML(response.ToXDocument()));
		}

		[Fact]
		public void Can_Generate_Dial_And_Mixed_Number_And_Client_Nouns()
		{
			var response = new TwilioResponse();
			response.Dial(
				new Number("+15551112222"),
				new Client("Tommy"),
				new Number("+15553334444"),
				new Number("+15556667777"),
				new Client("Jenny")
			);

			Debug.Write(response.ToString());
			Assert.True(IsValidTwiML(response.ToXDocument()));
		}
	}
}
