using UnityEngine;
using UnityEditor;

static class CardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<CardAsset>();
	}

	[MenuItem("Assets/Create/GroupAsset")]
	public static void CreateYourScriptableObject2()
	{
		ScriptableObjectUtility2.CreateAsset<GroupAsset> ();
	}

}
