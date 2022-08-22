using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Utility : MonoBehaviour
{
	public static void DestroyAll<T>(IEnumerable<T> list) where T : MonoBehaviour
	{
		foreach (var item in list)
			Destroy(item.gameObject);
	}
}
