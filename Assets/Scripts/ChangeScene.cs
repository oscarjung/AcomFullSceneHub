using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.SceneSystem;
using Microsoft.MixedReality.Toolkit.Extensions.SceneTransitions;
using Microsoft.MixedReality.Toolkit;

public class ChangeScene : MonoBehaviour
{

    // Start is called before the first frame update
    public async void ChangeSceneIntoRoom()
    {
        IMixedRealitySceneSystem sceneSystem = MixedRealityToolkit.Instance.GetService<IMixedRealitySceneSystem>();

        //** Scene Transition 
        ISceneTransitionService transition = MixedRealityToolkit.Instance.GetService<ISceneTransitionService>();

        // Fades out
        // Runs LoadContent task
        // Fades back in
        await transition.DoSceneTransition(
                () => sceneSystem.LoadContent("PanoraView")
            );
        
        //** Scene Transit

        // ContentScene1, ContentScene2 and ContentScene3 will be loaded additively
        //await sceneSystem.LoadContent("PanoraView");
        //await sceneSystem.LoadContent("RoomBounding");

        // ContentScene1, ContentScene2 and ContentScene3 will be unloaded
        // SingleContentScene will be loaded additively
        //await sceneSystem.LoadContent("RoomBounding", LoadSceneMode.Single);
    }
    
}
