﻿using App.Context;
using App.Controller;
using App.Repository.Impl;

namespace App.Factory
{
    /// <summary>
    /// 
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class ApplicationFactory
    {
        private static AppContext context = null;

        public static AppContext getAppContext()
        {
            if (context == null)
            {
                context = new AppContext();
            }

            return context;
        }

        public static UserRepository getUserRepository()
        {
            return new UserRepository(getAppContext());
        }

        public static ConferenceRepository getConferenceRepository()
        {
            return new ConferenceRepository(getAppContext());
        }

        public static PreliminaryPhaseController getPreliminaryPhaseController()
        {
            return new PreliminaryPhaseController(getUserRepository(), getConferenceRepository());
        }

        public static LoginController getLoginController()
        {
            return new LoginController(getUserRepository(), getConferenceRepository());
        }

        public static PhaseOneController getPhaseOneController()
        {
            return new PhaseOneController();
        }
    }
}