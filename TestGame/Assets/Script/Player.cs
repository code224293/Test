using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> skins=new List<GameObject>();
    private int index;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.name.StartsWith("Character_"))
            {
                skins.Add(child.gameObject);
            }
        }
        index = 0;
        RefleshSkin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefleshSkin()
    {
        for(int i = 0; i < skins.Count; i++)
        {
            if (i == index) skins[i].SetActive(true);
            else skins[i].SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        index++;
        index %= skins.Count;
        RefleshSkin();
    }
}
