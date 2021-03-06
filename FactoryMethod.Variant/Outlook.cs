﻿using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class Outlook
    {
        /// <summary>
        /// Load out look components
        /// </summary>
        public void LoadComponents()
        {
            List<Component> components = GetComponents();
            foreach (var component in components)
            {
                // Fill Menu & Navigator 
                FillMenu(component.MenuItems);
                FillNavigator(component.NavigatorItem);

                // Fill Work Area
                var workArea = component.CreateWorkArea();
                FillWorkArea(workArea);
            }
        }

        /// <summary>
        /// Get all outlook components
        /// (
        ///     here could be very flexible: 
        ///     you could check the component plugin folder 
        ///     to load all component DLLs into APP domain
        /// )
        /// </summary>
        /// <returns></returns>
        private List<Component> GetComponents()
        {
            return new List<Component>
            {
                new MailComponent(),
                new CalendarComponent(),
                new ContactComponent(),
            };
        }


        private void FillMenu(List<MenuItem> menuItems)
        {
            // ...
        }


        private void FillNavigator(ListViewItem navigatorItem)
        {
            // ...
        }


        private void FillWorkArea(WorkArea workArea)
        {
            // ...
        }
    }
}
