using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Utility : MonoBehaviour
{
	#region DestroyAll
	public static void DestroyAll(List<MonoBehaviour> list) 
	{
		for(int i = 0; i < list.Count; i++)
		{
			Destroy(list[i].gameObject);
		}
	}
	public static void DestroyAll(List<GameObject> list)
	{
		for(int i = 0; i < list.Count; i++)
		{
			Destroy(list[i].gameObject);
		}
	}
	public static void DestroyAll(Object[] list)
	{
		for(int i = 0; i < list.Length; i++)
		{
			Destroy(((Transform)list[i]).gameObject);
		}
	}
	#endregion
}
