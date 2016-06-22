﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace KEPServerSenderService
{
	public partial class SenderService : ServiceBase
	{
		#region Fields

		/// <summary>	The sender jobs. </summary>
		private SenderJobs senderJobs; 

		#endregion

        #region Constructor

        /// <summary>	Default constructor. </summary>
        public SenderService()
		{
			InitializeComponent();

            // Set up a timer to trigger every print task frequency.
            this.senderJobs = new SenderJobs();
        }

        #endregion

        #region Methods

        /// <summary>	Executes the start action. </summary>
        ///
        /// <param name="args">	Data passed by the start command. </param>
        protected override void OnStart(string[] args)
		{
			this.senderJobs.StartJob();
        }

		/// <summary>	Executes the stop action. </summary>
		protected override void OnStop()
		{
			this.senderJobs.StopJob();
        }
        #endregion
    }
}
