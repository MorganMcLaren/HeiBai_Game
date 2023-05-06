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
        public static string HeibeiColourToTag(HeibeiColour colour)
        {
            //If more colours are added, this switch must be updated with the correct tags
            string tag = "";
            switch (colour)
            {
                case HeibeiColour.BLACK:
                    {
                        tag = "Black";
                        break;
                    }
                case HeibeiColour.WHITE:
                    {
                        tag = "White";
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
        public static HeibeiColour colour;
        // Start is called before the first frame update

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
            /*if (bucket.gameObject.CompareTag("GroundChecker"))
            {
                Debug.Log("BUCKET");
                SwitchColour();
            }*/
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
        }


    }
}