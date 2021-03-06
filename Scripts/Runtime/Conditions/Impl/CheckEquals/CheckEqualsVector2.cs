﻿using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl.CheckEquals {
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "(Vector2) => Equals?")]
	public class CheckEqualsVector2 : BaseCheckEquals<Vector2Reference, Vector2Reference, Vector2> {
		protected override bool Inner_Call(Vector2 operand2) {
			return operand1.Value == operand2;
		}

		protected override Vector2 GetConverted(Vector2Reference fixedOperand2) {
			return fixedOperand2.Value;
		}
	}
}