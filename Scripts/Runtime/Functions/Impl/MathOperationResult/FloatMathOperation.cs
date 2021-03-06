﻿using System;
using Plugins.MathUtils;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.MathOperationResult {
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(float) => Math Operation : float",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class FloatMathOperation : FloatFloatFunction {
		[SerializeField]
		private MathOperationData<FloatReference> mathOperationData;
		
		public override float Call(float dynamicOperand1) {
			return GetOperationResult(dynamicOperand1);
		}

		public float Call() {
			return GetOperationResult(mathOperationData.FixedOperand1.Value);
		}

		private float GetOperationResult(float operand1) {
			float operand2 = mathOperationData.Operand2.Value;
			
			return mathOperationData.MathOperation switch {
				MathOperation.Sum => operand1 + operand2,
				MathOperation.Subtract => operand1 - operand2,
				MathOperation.Divide => operand1 / operand2,
				MathOperation.Multiply => operand1 * operand2,
				_ => throw new ArgumentOutOfRangeException()
			};
		}
	}
}