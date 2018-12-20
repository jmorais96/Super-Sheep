 using UnityEngine;
     using UnityEngine.SceneManagement;
     using System.Collections;
     
     public class Restart : MonoBehaviour {
      
         public void RestartGame() {
            SceneManager.LoadScene("GameScene"); // loads current scene
             CtrlLife.health = 3;
             gameObject.SetActive(false);
             Time.timeScale = 1;
         }
        
     }