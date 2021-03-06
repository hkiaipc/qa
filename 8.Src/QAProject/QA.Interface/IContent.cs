﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QA.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IContent
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// 
        /// </summary>
        IContainer Container
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentMenuItem"></param>
        /// <param name="parentToolStrip"></param>
        void Load(ToolStripMenuItem parentMenuItem, ToolStrip parentToolStrip);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inParameters"></param>
        /// <param name="outParameters"></param>
        void Execute(string name, ParameterCollection inParameters, ParameterCollection outParameters);
    }
}
