# 개요
`OSC`(Open Sound Control)을 활용해 `Unity`에서 `MadMapper`를 콘트롤하는 방법에 대한 설명입니다.

# 사전작업

## MadMapper

### OSC 연동 포트 설정하기
상단 메뉴에서 `Tools` → `Preferences...` 메뉴를 클릭하세요.  

<kbd><img src="Images/2021-11-02 10-50-48.png" height=500 /></kbd>

`OSC Input Port`를 설정하세요. (아래 그림에선 `8000`번으로 설정했습니다.)
<kbd><img src="Images/2021-11-02 10-52.png" height=500 /></kbd>

### **Scenes/Cues** 창 열기
장면(Scene)을 콘트롤 하기 위해서 사전에 장면 설정이 필요합니다.  
장면 설정은 `Scenes/Cues` 내에서 할 수 있습니다.

#### 방법 1
상단 메뉴에서 `Tools` → `Scenes / Cues` 메뉴를 클릭하세요.  

<kbd><img src="Images/2021-11-02 10-12-50.png" height=500 /></kbd>

#### 방법 2
하단 윈도우 내 드롭박스를 클릭하고, `Scenes / Cues` 메뉴를 클릭하세요.

<kbd><img src="Images/2021-11-02 09-19-45.png" height=500 /></kbd>

### 서페이스에 비디오 적용하기
모든 `Surface`(서페이스)를 드래그해 선택한 다음, 오른쪽 메뉴에서 비디오를 선택합니다.  
모든 서페이스에 해당 비디오가 적용됩니다.

<kbd><img src="Images/2021-11-02 09-56-55.gif" height=500 /></kbd>

### 장면 추가하기
현재 서페이스 설정을 `Scene`(장면)으로 추가합니다.

<kbd><img src="Images/2021-11-02 09-58-31.gif" height=500 /></kbd>

### 장면 썸네일 설정하기
장면에 대한 썸네일을 설정합니다.

<kbd><img src="Images/2021-11-02 10-05-44.gif" height=500 /></kbd>

### 장면 전환 옵션 설정하기
장면 전환에 대한 옵션을 설정합니다.  
(아래 예시에서는 `Transition Type`을 `Ease In Out`으로, `Duration`을 `0.5`초로 설정했습니다.)

<kbd><img src="Images/2021-11-02 10-35-07.gif" height=500 /></kbd>

### 장면 전환 미리보기
위와 같은 방법으로 한 개의 장면을 더 추가한 뒤, 장면 전환이 정상적으로 동작하는 지 확인합니다.

<kbd><img src="Images/2021-11-02 10-37-51.gif" height=500 /></kbd>

## Unity

### 원격 호스트 정보 입력하기
`Unity` 내에서 `MadMapper`가 설치돼 있는 컴퓨터의 호스트 정보를 입력합니다.

- Remote Host: `MadMapper`가 설치돼 있는 컴퓨터 IP.
- Remote Port: `MadMapper`내 설정돼 있는 `OSC` 연동 포트.

<kbd><img src="Images/2021-11-02 10-37-51.gif" height=500 /></kbd>

# 원격 콘트롤

## 쿼리 주소 복사하기
`MadMapper` 내에서 쿼리 주소를 복사합니다.

<kbd><img src="Images/2021-11-02 10-43-12.gif" height=500 /></kbd>

## 쿼리 주소 붙여넣기
`Unity` 내 버튼 UI 콜백 함수의 파라미터로 복사한 쿼리주소를 붙여 넣습니다.

## 콘트롤 동작 확인하기
