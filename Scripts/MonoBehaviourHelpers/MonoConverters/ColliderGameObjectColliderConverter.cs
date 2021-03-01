﻿using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.MonoConverters {
	public class ColliderGameObjectColliderConverter : BaseMonoConverter<ColliderGameObject, Collider> {
		protected override Collider Inner_Convert(ColliderGameObject entryValue) {
			return entryValue.Collider;
		}
	}
}