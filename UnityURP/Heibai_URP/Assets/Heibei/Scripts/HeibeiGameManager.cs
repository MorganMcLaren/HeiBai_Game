using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Heibei
{

    public class HeibeiGameManager : MonoBehaviour
    {
        static HeibeiGameManager _instance;
        Dictionary<HeibeiColour, List<GameObject>> _currentLevelColourObjects;

        public PauseMenu pauseMenu;

        // UI Objects to show or hide
       // public GameObject winPanel;
       // public GameObject losePanel;

        public static HeibeiGameManager Instance
        {
            get { return _instance; }
        }
        // Start is called before the first frame update
        void Awake()
        {
            if (_instance == null)
            {
                //We are the first instance
                _instance = this;
                //Dont destroy across scene loads
                DontDestroyOnLoad(this);
                InitManager(); //initialise this manager
            }
            else
            {
                //Destroy ourselves, there's another gamemanager already
                Destroy(gameObject);
            }

            Time.timeScale = 1f;

        }

        void Start()
        {
           // winPanel.SetActive(false);
           // losePanel.SetActive(false);
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                StarPickups.starsCollected = 0;
                ReloadCurrentLevel();
            }
        }

        void InitManager()
        {
            //Allocate the dictionary
            _currentLevelColourObjects = new Dictionary<HeibeiColour, List<GameObject>>();
        }

        //Build the lists of coloured objects for the current level;
        public void RefreshLevelObjectColours()
        {
            HeibeiColourUtil.FindColouredObjects(_currentLevelColourObjects);
        }
        public List<GameObject> GetColouredObjects(HeibeiColour colour)
        {
            return _currentLevelColourObjects[colour];
        }
        public List<GameObject> GetOtherObjects(HeibeiColour colour)
        {
            List<GameObject> objects = new List<GameObject>();
            foreach (KeyValuePair<HeibeiColour, List<GameObject>> kvp in _currentLevelColourObjects)
            {
                if (kvp.Key != colour)
                {
                    for (int i = 0; i < kvp.Value.Count; i++)
                    {
                        objects.Add(kvp.Value[i]);
                    }
                }
            }
            return objects;
        }

        public void ReloadCurrentLevel()
        {
            Scene s = SceneManager.GetActiveScene();
            SceneManager.LoadScene(s.name);
            StarPickups.starsCollected = 0;
        }
        public void WinLevel()
        {
           // winPanel.SetActive(true);
        }
        public void LoseLevel()
        {
           // losePanel.SetActive(true);
        }
    }
}