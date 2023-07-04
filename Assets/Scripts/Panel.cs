using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] private List<Image> Backgrounds;
    [SerializeField] GameObject player;


    private int currentlySelected = -1;
    private CrateCreater crateInstance;

    // Start is called before the first frame update
    void Start()
    {
        crateInstance = player.GetComponentInChildren<CrateCreater>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentlySelected != crateInstance.currentIndex)
        {
            currentlySelected = crateInstance.currentIndex;
            //change colors of outline
            for (int i = 0; i < Backgrounds.Count; i++)
            {
                if (i == currentlySelected)
                {
                    Backgrounds[i].color = Color.green;
                }
                else
                {
                    Backgrounds[i].color = Color.white;
                }
            }
        }
    }
}
