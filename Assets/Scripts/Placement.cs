using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{
    [SerializeField]
    public int width = 13;
    public float offset = 3;
    // Start is called before the first frame update


/*    void Start()
    {
        List<Transform> allChildren = new List<Transform>(GetComponentsInChildren<Transform>());
        int i = 0;
        int j = 0;
        while (allChildren.Count > 0)
        {
            int index = Random.Range(0, allChildren.Count);
            allChildren[index].position = new Vector3(i * offset, 0, j * offset);
            allChildren.RemoveAt(index);
            i++;
            if (i > width)
            {
                i = 0;
                j++;
            }
        }
    }
*/
    void Start()
    {
        List<Transform> allChildren = new List<Transform>(GetComponentsInChildren<Transform>());
        allChildren.RemoveAt(0);
        List<int> randind = new List<int>();

        for (int k = 0; k < allChildren.Count; k++)
        {
            randind.Add(k);
        }

        int i = 0;
        int j = 0;
        for (int l = 0; l < allChildren.Count; l++)
        {
            int index = randind[Random.Range(0, randind.Count)];
            randind.Remove(index);
            allChildren[index].localPosition = new Vector3(i * offset, 0, j * offset);
            i++;
            if (i == width)
            {
                i = 0;
                j++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}