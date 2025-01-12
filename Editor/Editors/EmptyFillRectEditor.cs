﻿using UnityEngine;
using UnityEditor;
using UnityEditor.UI;

using EmptyFillRect = NicoplvTools.UiShapesKit.Shapes.EmptyFillRect;

[CustomEditor(typeof(EmptyFillRect))]
[CanEditMultipleObjects]
public class EmptyFillRectEditor : GraphicEditor
{
	protected override void OnEnable()
	{
		base.OnEnable();
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update();

		RaycastControlsGUI();

		serializedObject.ApplyModifiedProperties();
	}
}
