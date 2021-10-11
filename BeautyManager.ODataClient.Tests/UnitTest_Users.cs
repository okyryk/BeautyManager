using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using BeautyManager.Web.Data;
using System.IO;

using Microsoft.OData.Client;
using Default;
using System.Text;

namespace BeautyManager.ODataClient.Tests
{
	public class TestsUsers
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test_Get()
		{
			Default.Container dsc = new Default.Container(new System.Uri(TestHelper.ODataUri));
			var v = dsc.Users.GetAllPages();
			Assert.Pass();
		}

		[Test]
		public void Test_Upate()
		{
			string OriginalValue = null;
			string UpdatedValue = null;
			string ValueForUpdate = "okyryk";
			var context = new Container(new System.Uri(TestHelper.ODataUri));
			context.SendingRequest2 += (sender, eventArgs) =>
			{

			};
			var user = context.Users.First();
			OriginalValue = user.FirstName;

			user.FirstName = ValueForUpdate;
			context.UpdateObject(user);
			context.SaveChanges();

			user = context.Users.First();

			UpdatedValue = user.FirstName;

			user.FirstName = OriginalValue;

			context.UpdateObject(user);
			context.SaveChanges();

			Assert.AreEqual(UpdatedValue, ValueForUpdate);
		}


		[Test]
		public void Test_Add()
		{
			var context = new Container(new System.Uri(TestHelper.ODataUri));
			context.SendingRequest2 += clientContainer_SendingRequest2;
			context.BuildingRequest += Context_BuildingRequest;
			context.ReceivingResponse += Context_ReceivingResponse;

			context.AddToUsers(new User() { Id = "", FirstName = "FirstName", LastName = "LastName" });

			context.SaveChanges();

			Assert.Pass();
		}

		private void Context_ReceivingResponse(object sender, ReceivingResponseEventArgs e)
		{

		}

		private void Context_BuildingRequest(object sender, BuildingRequestEventArgs e)
		{
			
		}

		void clientContainer_SendingRequest2(object sender, SendingRequest2EventArgs e)
        {
            string accept = e.RequestMessage.GetHeader("Accept");
            string timestamp = DateTime.UtcNow.ToString("o");
            switch (e.RequestMessage.Method)
            {
                case "GET":
                    break;
                case "MERGE":
                    break;
                case "POST":
					break;
            }
        }
    }
}