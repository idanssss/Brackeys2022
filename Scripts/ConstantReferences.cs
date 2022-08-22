using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantReferences : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();
    public List<MonoBehaviour> scripts = new List<MonoBehaviour>();
    public List<Texture2D> Textures = new List<Texture2D>();

    public static ConstantReferences instantce;
    
    private void Awake()
    {
        instantce = this;
    }
}
