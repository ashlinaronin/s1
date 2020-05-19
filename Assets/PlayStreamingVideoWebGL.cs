using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayStreamingVideoWebGL : MonoBehaviour
{
    [Tooltip("name of a file in the StreamingAssets folder to play")]
    public string filename;
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer player = GetComponent<VideoPlayer>();
        player.url = System.IO.Path.Combine(Application.streamingAssetsPath, filename); 
        player.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
