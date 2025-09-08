using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace BenchwarpSS.Utils
{
    public class GUIController : MonoBehaviour
    {
        public GameObject canvas;
        private static GUIController _instance;
        public Font BenchwarpFont;
        public Font Fallback = Font.CreateDynamicFontFromOSFont("Consolas", 16);

        private GameObject warpBtn;
        private GameObject btnText;

        public static void Setup()
        {
            GameObject GUIObj = new("Benchwarp GUI");
            _instance = GUIObj.AddComponent<GUIController>();
            DontDestroyOnLoad(GUIObj);
        }

        public static void Unload()
        {
            Destroy(_instance.canvas);
            Destroy(_instance.gameObject);
        }

        public void GUIUpdate()
        {
            if (BenchwarpFont == null)
            {
                foreach (Font f in Resources.FindObjectsOfTypeAll(typeof(Font)))
                {
                    if (f.name == "TrajanPro-Regular")
                    {
                        BenchwarpFont = f;
                        btnText.GetComponent<Text>().font = BenchwarpFont;
                    }
                }
            }
        }

        public void BuildMenus()
        {
            canvas = new GameObject();
            Canvas canvas_component = canvas.AddComponent<Canvas>();
            canvas_component.renderMode = RenderMode.ScreenSpaceOverlay;
            CanvasScaler scaler = canvas.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            canvas.AddComponent<GraphicRaycaster>();

            warpBtn = new("Warp Button", typeof(RectTransform));
            warpBtn.transform.SetParent(canvas.transform, false);
            Button button_component = warpBtn.AddComponent<Button>();
            button_component.onClick.AddListener(SaveReload);

            RectTransform rt = warpBtn.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(160, 40); // width x height
            rt.anchorMin = new Vector2(0, 1);    // top-left
            rt.anchorMax = new Vector2(0, 1);
            rt.pivot = new Vector2(0, 1);
            rt.anchoredPosition = new Vector2(10, -10); // offset from top-left

            btnText = new GameObject("ButtonText", typeof(RectTransform));
            btnText.transform.SetParent(warpBtn.transform, false);

            Text text = btnText.AddComponent<Text>();
            text.text = "WARP";

            if (BenchwarpFont == null)
            {
                text.font = Fallback;
            } else
            {
                text.font = BenchwarpFont;
            }

            text.alignment = TextAnchor.MiddleCenter;
            text.color = Color.white;

            RectTransform textRT = btnText.GetComponent<RectTransform>();
            textRT.anchorMin = Vector2.zero;
            textRT.anchorMax = Vector2.one;
            textRT.offsetMin = Vector2.zero;
            textRT.offsetMax = Vector2.zero;

            DontDestroyOnLoad(canvas);
        }

        public void SaveReload()
        {
            GameManager gm = GameManager.instance;
            if (gm == null)
            {
                ModHelper.Msg("GM IS NULL HERE");
                return;
            }
            gm.SaveGame((worked) =>
            {
                if (worked)
                {
                    gm.LoadGameFromUI(gm.profileID);
                }
            });

            gm.PauseGameToggle(false);
        }

        public static GUIController Instance
        {
            get
            {
                if (_instance != null) return _instance;

                _instance = FindFirstObjectByType<GUIController>();

                if (_instance != null) return _instance;

                ModHelper.Msg("Couldn't find GUIController");

                GameObject GUIObj = new();
                _instance = GUIObj.AddComponent<GUIController>();
                DontDestroyOnLoad(GUIObj);

                return _instance;
            }
        }
    }
}
