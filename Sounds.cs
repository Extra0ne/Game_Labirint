using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint_0._0
{
   static class Sounds
    {
       static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);
       static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key);
       static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
       static SoundPlayer sound_win = new SoundPlayer(Properties.Resources.sound_win);
       static SoundPlayer sound_press = new SoundPlayer(Properties.Resources.sound_press);
       static bool sound_enabled = true;

       public static void sound_on()
       {
           sound_enabled = true;
       }
       public static void sound_off()
       {
           sound_enabled = false;
       }
      public static void play_start()
       {
           if (sound_enabled)
           {
               sound_start.Play();
           }
       }
      public static void play_key()
      {
          if (sound_enabled)
          {
              sound_key.Play();
          }
      }
      public static void play_fail()
      {
          if (sound_enabled) 
          {
              sound_fail.Play();
          }
      }
      public static void play_win()
      {
          if (sound_enabled)
          {
              sound_win.Play();
          }
      }
      public static void play_press()
      {
          if (sound_enabled)
          {
              sound_press.Play();
          }
      }

    }
}
