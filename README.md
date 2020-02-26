ABHD Game (UnityVR)
======================

# 1. 개요
## 1.1. 게임 명
A Bad Hair Day  : 안 풀리는 하루

## 1.2. 장르
사운드 플레이 기반 어드벤처 게임 제작 (Unity VR)

## 1.3. 목적
Unity 엔진을 이용해서 사운드 플레이 기반 방 탈출 게임 제작

## 1.4. 게임 소개
* **기존 게임** : 게임을 플레이 하는데 있어 **'소리'** 는 유용한 **'보조 수단'** 
* **A Bad Hair Day** : 게임 클리어를 위해 **'소리'** 는 물건을 찾기 위한  **'필수 요소'**
```
- 주인공은 평범한 대학생이다.
- 학교를 가기 전, 핸드폰을 잃어버렸다.
- 5분 안에 핸드폰을 찾지 못하면 버스를 놓친다.
- 그런 와중에 핸드폰에서 카톡 알람이 계속 울린다.
- 핸드폰은 시각적으로 보이지 않는다.
```

## 1.5. 개발 범위
* **Scene**
```
* Intro
- 게임 정보, 시작, 종료 기능을 포함하여 씬을 구성한다. 

* Dialog
- 사용자에게 대화 및 Animation 기능을 통해 게임 컨셉에 대한 정보를 제공한다.

* Game
- Sound, Interactable, Non-Interactable 오브젝트를 이용해 사운드 플레이 기반 어드벤처 게임을 제작한다.
```

* **Object**
```
* Sound Object
- 3D 음향을 기반으로 물체를 생성 및 정의한다.

* Interactable Object
- 3D 음향을 기반하고 있는 물체와 그렇지 않은 물체를 생성하고, 사용자와의 상호작용을 정의한다.
- 소리를 끄는 기능을 정의한다.

* Non - Interactable Object 
- 사용자의 행위를 방해하는 요소로 물체를 생성하되, 정의하지 않는다.
```

## 1.6. 개발 환경
* Unity 2019.2.9f1 Personal
* Visual Studio 2019
* 3ds Max 2020

## 1.7. 본인 역할
* 모델링 적용
* 프로그램 기획 참여
* 프로그램 개발 총괄 (Intro, Dialog, Game 씬 개발)
 
****
# 2. 구조 설계
## 2.1. 클래스 구조도
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/클래스.png" width="800" height="300"><br>
</p>

* **Game Manager** : 게임에 대한 전체적인 흐름을 담당한다. (Scene, Fade In & out, Timer UI, Story Image)
```
* Sound Manager
- 게임에 사용되는 모든 Sound를 보관하고, 출력하는 기능을 담당한다.

* Dialogue Manager
- 게임에 등장하는 모든 대화와 그에 상응하는 Image 출력 기능을 담당한다.
```


* **OVR Player** : Oculus에서 제공하는 Player 컴포넌트와 관련된 C# 스크립트를 오버라이딩하여 기능을 제공한다.
```
* OVR Camera Rig
- Tracking Type 을 Floor Level로 변경한다.

* OVR Player Controller
- Player의 너비와 높이를 물리적인 공간에서 제약없이 수행되도록 설정한다.

* Hand Controller
- Collider 설정과, OVR Grabber 컴포넌트를 이용해 물건 잡기를 구현한다.
```


* **UI** : 화면에 표시 되어야 할 게임 정보 및 대화와 관련된 모든 정보를 출력하는 기능을 담당한다. 
```
* Game Status
- 게임의 현재 상태 정보를 제공한다.

* Game Info
- 게임의 스토리 출력 및 플레이어와 오브젝트간의 Tracking 정보 출력 기능을 제공한다.

* Dialogue
- Dialogue Manager를 통해 플레이어와 게임간의 대화 텍스트 출력 및 Animaion 기능을 제공한다.
```


* **Item** : 게임 Item 고유의 특성 및 Tracking 기능을 정의한다.  
```
* Sound Item
- 3D 입체 음향 기법을 이용해 Audio Source 컴포넌트를 정의한다.

* Interactable Item
- 플레이어가 잡을 수 있고, 상호작용을 통해 다른 물체를 조작할 수 있는 기능을 정의한다.

* Non-Interactable Item
- 상호작용이 없는 물체들의 Collider 및 Rigidbody 설정을 통해 정의한다.
```

## 2.2. 씬 구조도
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/씬.png" width="800" height="300"><br>
</p>

* **구성**
```
* Intro
Start : Dialog 씬을 실행한다.
Story : 게임의 스토리에 관한 정보를 참고한다.
Exit : 게임을 종료한다.

* Dialog
Next : 다음 대사와 이미지를 출력한다.
Game : Game 씬을 실행한다.

* Game
Game Clear : 플레이어 오른쪽 컨트롤러를 이용해 핸드폰을 찾으면 탈출하고, 5초 후에 Intro 씬으로 이동한다.
```

****
# 3. 주요 구현부
## 3.1. Coroutine
* **TypeWriter()**<br>
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro1.png" width="500" height="400"><br>
</p>

```
* 설명
- 마지막 대화 출력 시, Next 버튼을 비활성화 하고, Game 버튼을 활성화한다.
- 텍스트를 한 글자씩 딜레이를 주면서 출력하기 위해 Coroutine을 사용한다.
```

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro2.png" width="500" height="500"><br>
</p>

```
* 설명
- 마지막 배열 인덱스가 아니라면, Next 버튼을 활성화한다. 
- contextCount 변수를 이용해 대화의 순서를 읽고, 각 순서에 출력할 Animation을 실행한다.
- 텍스트를 한 글자씩 딜레이를 주면서 출력하기 위해 Coroutine을 사용한다.
```

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro3.png" width="500" height="400"><br>
</p>

```
* 설명
- Next 버튼 클릭 시, 이전의 Sound를 중지하고, 모든 Bool 값을 false로 바꿔준다.
- Next 버튼 클릭 시, Text 내용을 잠시 없애준다.
- Next 버튼 클릭 시, 모든 UI 및 버튼을 잠시 비활성화한다.
- if 문을 통해 contextCount 변수를 업데이트 하고, 대사에 맞는 사운드를 재생한다.
- 이어서, Coroutine을 실행한다.
```

* **CountDownTimer()**<br>
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro4.png" width="600" height="500"><br>
</p>

```
* 설명
- 초 저장 변수를 선언하고, 초기화한다.
- TimeSpan 구조체를 이용해 분, 초 간격으로 나누고, 이를 Timer UI에 해당 텍스트를 저장한다.
- 초 저장 변수가 0이 되면, Game Over로 간주하고, GameOver() Coroutine을 실행한다.
- 5초의 여유시간을 주고, Intro 씬으로 전환한다.
```

## 3.2. ClosePos
* **ClosePhone()**
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/close.png" width="500" height="400"><br>
</p>

```
* 설명
- Vector3의 sqrMagnitude를 이용해 크기의 제곱 값을 저장한다.
- 이후, if문을 이용해 지정한 거리 범위의 제곱 값과 현재 거리의 제곱 값을 비교한다.
- 크기의 제곱 값을 비교하는 방법은 루트 연산을 하지 않기 때문에 연산 속도가 더 빠르므로 크기를 비교하는 것보다 더 효율적이다.
```

****
# 4. 참고
## 4.1. 참여 목록
* **2019 콘텐츠원캠퍼스 구축운영 및 VR 콘텐츠 개발 사업**<br>
    -입체 및 공간 음향을 활용한 방 탈출 게임(VR) 개발<br>
    [문화체육관광부, KOCCA(한국콘텐츠진흥원), 성결대학교 산학협력단, XRCENTER, 안양창조산업진흥원]<br>
    
* **학생주도 연구 프로그램 지원 사업**<br>
    -노력 정당화 이론 기반의 가상현실 콘텐츠 개발<br>
    [성결대학교 미래발전연구원]

## 4.2. 스크린 샷
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/스크린1.png" width="800" height="300"><br>
</p>

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/스크린2.png" width="700" height="400"><br>
</p>

## 4.3. 참고 url
* 게임 플레이 영상 : <https://youtu.be/BGeL1tWlY9w/>
