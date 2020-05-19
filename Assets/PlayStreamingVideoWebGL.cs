using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayStreamingVideoWebGL : MonoBehaviour
{
    [Tooltip("name of a file in the StreamingAssets folder to play")]
    public string filename;
    private VideoPlayer player;
    void Awake()
    {
        player = GetComponent<VideoPlayer>();
        player.url = System.IO.Path.Combine(Application.streamingAssetsPath, filename);
    }

    private void Update() {
        if (!player.isPlaying) {
            player.Play();
        }
    }
}
