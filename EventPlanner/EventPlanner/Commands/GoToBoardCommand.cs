﻿using EventPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EventPlanner.Commands
{
    class GoToBoardCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}