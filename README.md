# SmartHome-AR

A concept of controlling smart home appliances though AR interface 😉.

It's a college final year project implemented on Android (Back in 2017), but can also supports iOS.

## How it works?

The switch controls will be shown virtually when you point your mobile camera to a smart appliance.

![How it works](https://raw.githubusercontent.com/lvabarajithan/SmartHome-AR/master/how-it-works.png)

Hover/Gesture your hand over the switch (in an AR way) will toggle the state of the smart appliance.

- You can see the `conference paper` for more understanding.

- Also attached the `slides` used for demo presentation.

**Virtual buttons:**

![ar-interface](https://raw.githubusercontent.com/lvabarajithan/SmartHome-AR/master/ar-interface.png)

**On action:**

![led is on](https://raw.githubusercontent.com/lvabarajithan/SmartHome-AR/master/led-on.png)

## Applications
- Smart glasses (Ironman style 😎)
- Possibilities are countless...

## Setup environment and tools

1. Android SDK
2. Unity
3. Vuforia engine
4. QR code or some image (for AR interfacing)
5. Firebase project
6. AndroidThings board for IOT (or RaspberryPi)
7. An Android device with camera ofcourse 😁

### Setup Vuforia

- Create an account in Vuforia portal
- Upload the AR interfacing image or QR code for masking
- Build and import onto the project

![masking](https://raw.githubusercontent.com/lvabarajithan/SmartHome-AR/master/masking.png)

### Setup AndroidThings

- Download and Flash latest Android Image
- Create an Android app project
- Design a cool interface indicating 2 LEDs. (I didn't use real LEDs for demo but Android Things has GPIO controls)
- Add Firebase library dependencies
- Connect to Firebase realtime database (Setup instructions are below 👇🏻)
- Listen to the realtime database for changes (Database configured below 👇🏻)
- Update UI accordingly
- Upload the app to AndroidThings

![android things](https://raw.githubusercontent.com/lvabarajithan/SmartHome-AR/master/android-things-board.png)

### Setup Firebase project

- Create a new Firebase project - (**SmartHome App**)
- Import the `google-services.json` file onto Unity app and AndroidThings app.
- Init Realtime database, like

```json
{
  "controls": {
    "led1": true,
    "led2": false
  }
}
```

The `controls` is the root of the database. The control values `led1` and `led2` indicate the ON/OFF state of the LEDs.

### Setup Unity app

- Setup Firebase Unity project (See [here](https://firebase.google.com/docs/unity/setup))
- Setup Firebase Realtime database (See [here](https://firebase.google.com/docs/database/unity/start))

Note: Project contains **outdated** library and implementation of Realtime database. Recommend to upgrade them.

## License

```
MIT License

Copyright (c) 2020 Abarajithan LV

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
