# MG3
## Devlog
1. The default value for floats, ints, bools, and strings are: 0, 0, false, and blank (in that order)
2. You can't call an Update(). You need Monobehavior to be attached to the active Gameobject to enable. Because the time between frame varies, timers usually use Time.deltaTime (seconds since the last frame) to keep track of elasped time. If you called Update() yourself, it would run an extra time that frame and throw the timing off.
3. The KickWeapon uses the Timer class to control how long the kick stay active. It has a Timer reference called _lifeTimer and _lifetimeSeconds value that you set in the Inspector. When ActivateKick() is called, the kick object is turned on with gameObject.SetActive(true), and then _lifetimer.BeginTimer(_lifetimeSeconds) starts counting down from that number of seconds. From there, Unity called Update(). In Timer, Update() subtracts Time.deltaTime from timeLeft, so the timer counts down. In KickWeapon, Update() calls _lifeTimer.IsFinished() each frame, which returns true once timeLeft is 0 or less. Then, gamObject.SetActive(false) turns the kick off. The result is a kick that appeats when activated and disappears after _lifetimeSeconds.
## Open-Source assets
- [Cat fighter spritesheet](https://opengameart.org/content/cat-fighter-sprite-sheet)
- [Food sprites](https://rcpstd.itch.io/pixel-food-pack)