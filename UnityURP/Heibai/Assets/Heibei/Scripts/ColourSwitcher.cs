using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heibei
{


    
    public enum HeibeiColour
    {
        BLACK = 0,
        WHITE
    }

    public static class HeibeiColourUtil
    {
        //public static string tag = "";
        public static string HeibeiColourToTag(HeibeiColour colour)
        {
            //If more colours are added, this switch must be updated with the correct tags
            string tag = "";
            switch (colour)
            {
                case HeibeiColour.BLACK:
                    {
                        tag = "Black";
                        Debug.Log("Black");
                        break;
                    }
                case HeibeiColour.WHITE:
                    {
                        tag = "White";
                        Debug.Log("White");
                        break;
                    }
            }
            return tag;
        }

        /* 
            Look in the current scene. Store all objects sorted into their colours
        */
        public static void FindColouredObjects(Dictionary<HeibeiColour, List<GameObject>> dict)
        {
            //clear the dictionary
            dict.Clear();

            foreach (HeibeiColour colour in new HeibeiColour[]
                {
                    HeibeiColour.BLACK,
                    HeibeiColour.WHITE }
            ) //add more colours here if you have them.
            {
                //Find all objects of that colour.
                string tagname = HeibeiColourUtil.HeibeiColourToTag(colour);
                if (tagname != "") //guard against unrecognised tags/colours
                {
                    GameObject[] objects = GameObject.FindGameObjectsWithTag(tagname);
                    //Make a new list to hold the objects
                    dict[colour] = new List<GameObject>();
                    //Copy each one into the list
                    for (int i = 0; i < objects.Length; i++)
                    {
                        dict[colour].Add(objects[i]);
                    }
                }
            }
        }
    }

    public class ColourSwitcher : MonoBehaviour
    {
        public HeibeiColour colour;
        public bool currentColour = false;
        private PauseMenu pauseMenu;
        // Start is called before the first frame update

        private void Awake()
        {
            pauseMenu = FindObjectOfType<PauseMenu>();
            Debug.Log("Pause menu:" + pauseMenu);
        }

        void SwitchColour()
        {
            //Find all objects of our colour, and turn them on.
            List<GameObject> onObjects = HeibeiGameManager.Instance.GetColouredObjects(colour);
            for (int i = 0; i < onObjects.Count; i++)
            {
                GameObject o = onObjects[i];
                if (o != null)
                {
                    EnableObject(o, true);
                }
            }
            //Find all objects that arent our colour, and turn them off
            List<GameObject> offObjects = HeibeiGameManager.Instance.GetOtherObjects(colour);
            for (int i = 0; i < offObjects.Count; i++)
            {
                GameObject o = offObjects[i];
                if (o != null)
                {
                    EnableObject(o, false);
                }
            }
        }

        // When a collision happens, switch colours to our colour, and destroy ourself.
        void OnTriggerEnter2D(Collider2D bucket)
        {
            Debug.Log("BUCKET");
            SwitchColour();
            pauseMenu.SetColour(colour);
            Debug.Log("Pause menu colour: " + colour);
            Destroy(gameObject); //destroy ourselves
        }

        void EnableObject(GameObject g, bool onStatus = true)
        {
            SpriteRenderer renderer = g.GetComponent<SpriteRenderer>();
            Collider2D collider = g.GetComponent<Collider2D>();

            if (renderer)   //if we found a renderer
            {
                renderer.enabled = onStatus; //turn the renderer on or off
            }
            if (collider) //if we found a collider
            {
                collider.enabled = onStatus; //turn the collider on or off
            }
            //Debug.Log("current colour" + HeibeiColourUtil.currentColour);
            Debug.Log("Colour tag is " + tag);
        }
    }
}