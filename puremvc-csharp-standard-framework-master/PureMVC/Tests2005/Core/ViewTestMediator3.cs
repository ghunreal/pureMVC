/* 
 PureMVC C# Port by Andy Adamczak <andy.adamczak@puremvc.org>, et al.
 PureMVC - Copyright(c) 2006-08 Futurescale, Inc., Some rights reserved. 
 Your reuse is governed by the Creative Commons Attribution 3.0 License 
*/
using System;
using System.Collections.Generic;

using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace PureMVC.Tests.Core
{
    /**
  	 * A Mediator class used by ViewTest.
  	 * 
  	 * @see org.puremvc.csharp.core.view.ViewTest ViewTest
  	 */
    public class ViewTestMediator3 : Mediator, IMediator
    {
        /**
		 * The Mediator name
		 */
        public new static string NAME = "ViewTestMediator3";

        /**
         * Constructor
         */
        public ViewTestMediator3(object view)
            : base(NAME, view)
        { }

		override public IList<string> ListNotificationInterests()
        {
            // be sure that the mediator has some Observers created
            // in order to test removeMediator
			return new List<string>(new string[] { ViewTest.NOTE3 });
        }

        override public void HandleNotification(INotification notification)
		{
			ViewTest.lastNotification = notification.Name;
		}

        public ViewTest ViewTest
		{
			get { return (ViewTest) m_viewComponent; }
		}
    }
}
