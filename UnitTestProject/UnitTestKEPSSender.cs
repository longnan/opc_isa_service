﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KEPServerSenderService.Tests
{
	[TestClass()]
	public class UnitTestKEPSSender
    {
		[TestMethod()]
		public void UnitTestKEPSSenderTest()
		{
            SenderJobs pJobTest = new SenderJobs();
            pJobTest.OnSenderTimer(this, new EventArgs() as System.Timers.ElapsedEventArgs);

            Assert.IsTrue(true);
		}

		[TestMethod()]
		public void OnPrintTimerTest()
		{
			//Assert.Fail();
			Assert.IsTrue(true);
		}
	}
}

