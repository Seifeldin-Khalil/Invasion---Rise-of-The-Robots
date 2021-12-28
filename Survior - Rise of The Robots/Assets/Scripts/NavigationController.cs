using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController :LevelManager
{
    // Main Menu Scene
    public void GoToIntroScene()
    {
        Application.LoadLevel(0);
    }
    public void GoToGameCutScene1()
    {
        Application.LoadLevel(1);
    }
    // Level 1 Scene 1 
    public void GoToGameScene11()
    {
        Application.LoadLevel(2);
    }
    
    public void Respawn()
    {
        LevelManager.respawnplayer();
    }
    //// Level 1 Scene 2 
    //public void GoToGameScene12()
    //{
    //    Application.LoadLevel(2);
    //}1

    //// Level 2 Scene 1 
    //public void GoToGameScene21()
    //{
    //    Application.LoadLevel(3);
    //}
    //// Level 2 Scene 2 
    //public void GoToGameScene22()
    //{2
    //    Application.LoadLevel(4);
    //}

    //// Level 3 Scene 1 
    //public void GoToGameScene31()
    //{
    //    Application.LoadLevel(5);
    //}
    //// Level 3 Scene 2 
    //public void GoToGameScene32()
    //{
    //    Application.LoadLevel(5);
    //}

    //// Level 4 Scene 1 
    //public void GoToGameScene41()
    //{
    //    Application.LoadLevel(6);
    //}
    //// Level 4 Scene 2 
    //public void GoToGameScene42()
    //{
    //    Application.LoadLevel(7);
    //}

    public void GoToGameOverScene()
    {
        Application.LoadLevel(10);
    }
    public void GoToVictoryScene()
    {
        Application.LoadLevel(11);
    }
    public void Quit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
