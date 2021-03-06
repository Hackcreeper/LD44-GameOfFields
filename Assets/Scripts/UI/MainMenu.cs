using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        private FollowingCamera followingCamera;

        [SerializeField]
        private Transform rotationTarget;

        [SerializeField]
        private Text playerNumText;

        [SerializeField]
        private Slider playerSlider;

        [SerializeField]
        private GameObject menu;
        
        [SerializeField]
        private GameObject introduction;

        public void ShowIntroduction()
        {
            menu.SetActive(false);
            introduction.SetActive(true);
        }
        
        private void Start()
        {
            followingCamera.SetTarget(rotationTarget);
            followingCamera.RotateAround();
        }

        public void UpdatePlayerNumText()
        {
            playerNumText.text = playerSlider.value.ToString();
        }

        public void StartGame()
        {
            PlayerHolder.GetInstance().SetPlayerAmount((int)playerSlider.value);
            SceneManager.LoadScene("Game");
        }
    }
}