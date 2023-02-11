
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadMenu : MonoBehaviour
{
   public void LoadNextScene()
   { 
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void Restart() 
   {
      SceneManager.LoadScene("menu");
   }
   } 

 
   

