﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Martin Koníček" email="martin.konicek@gmail.com"/>
//     <version>$Revision$</version>
// </file>
using Debugger.AddIn.TreeModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Debugger.AddIn.Visualizers
{
	/// <summary>
	/// Executes object graph visualizer for a node.
	/// </summary>
	public class ObjectGraphVisualizerCommand : ExpressionNodeVisualizerCommand
	{
		public ObjectGraphVisualizerCommand(ExpressionNode expressionNode)
			:base(expressionNode)
		{
		}
		
		public override bool CanExecute { 
			get { return true; }
		}
		
		public override string ToString()
		{
			return "Object graph visualizer";
		}
		
		public override void Execute()
		{
			
		}
	}
}
