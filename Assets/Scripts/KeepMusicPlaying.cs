using UnityEngine;
 
 public class KeepMusicPlaying : MonoBehaviour
 {
     private AudioSource _audioSource;
     private GameObject[] audioCount;

     private void Awake()
     {
        DontDestroyOnLoad(transform.gameObject);
        
        _audioSource = GetComponent<AudioSource>();
     }
 
     public void PlayMusic()
     {
         if (_audioSource.isPlaying) return;
         _audioSource.Play();
     }
 
     public void StopMusic()
     {
         _audioSource.Stop();
     }
 }