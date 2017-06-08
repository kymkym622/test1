using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{

    public class dataTarget : MonoBehaviour
    {
    

        public Transform TextTargetName;
        public Transform TextDescription;
        //public Transform ButtonAction;
        //public Transform PanelDescription;

        // public AudioSource soundTarget;
        //  public AudioClip clipTarget;

        // Use this for initialization
        /*void Start()
        {
            //add Audio Source as new game object component
            //soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }
        */
        void Update()
        // Update is called once per frame
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                //ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                //PanelDescription.gameObject.SetActive(true);


                //If the target name was “Kim” then add listener to ButtonAction with location of the sound (locate in Resources/sounds folder) and set text on TextDescription a description of the Kim

                if (name == "Kim")//
                {
                    //ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/"); });
                    TextDescription.GetComponent<Text>().text = "Successful! 김치찌개는 김치로 만들어진 찌개인 김치인 찌개인 김치";
                }



                //If the target name was “chi” then add listener to ButtonAction with location of the chi sound (locate in Resources/sounds folder) and set text on TextDescription a description of the kim

                if (name == "chi")
                {
                    //ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/chi"); });
                    TextDescription.GetComponent<Text>().text = "Successful! 김치찌개는 김치로 만들어진 찌개인 김치인 찌개인 김치";
                }
            }
        }
        /*
        //function to play sound
        void playSound(string ss)
        {
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }*/
    }
}