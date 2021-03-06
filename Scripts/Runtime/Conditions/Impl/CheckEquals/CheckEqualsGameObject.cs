﻿using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl.CheckEquals {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName =
		AtomsConstants.ConditionsCreateAssetMenuPath + "(GameObject) => Equals?")]
	public class CheckEqualsGameObject : BaseCheckEquals<GameObjectReference, GameObjectReference, GameObject> {
		protected override bool Inner_Call(GameObject operand2) {
			return operand1.Value == operand2;
		}

		protected override GameObject GetConverted(GameObjectReference fixedOperand2) {
			return fixedOperand2.Value;
		}
	}
}