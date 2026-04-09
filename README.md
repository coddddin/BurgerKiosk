# # (C# 코딩 6주차) 버거 주문 키오스크 (Burger Kiosk) 구현
***-- 22017004 컴퓨터 SW 강희준 --***

## 📑 개요: C# 프로그래밍 학습
- 선택 제어 컨트롤을 활용한 키오스크 주문 시스템 인터페이스 및 로직 구현

###  사용한 플랫폼
- **Language & Framework:** C#, .NET Windows Forms
- **IDE:** Visual Studio 2022
- **Version Control:** GitHub

###  사용한 컨트롤
- **단일 선택:** RadioButton (메인 메뉴 선택용)
- **컨테이너:** GroupBox (메뉴 그룹화)
- **시각화:** PictureBox (메뉴 이미지 출력)
- **입력 및 출력:** Label (제목 및 가격 표시)

### 💻 사용한 기술 및 개념 
- **RadioButton의 특성:** 여러 항목 중 오직 하나만 선택할 수 있는 '단일 선택' 컨트롤의 원리를 이해하고 적용함.

- **GroupBox의 역할:** 연관된 `RadioButton`들을 하나의 `GroupBox`로 묶어, 해당 그룹 내에서만 상호작용되도록 함.

- **UI 레이아웃 설계:** 사용자가 메뉴를 직관적으로 인식할 수 있도록 `PictureBox`와 `RadioButton`로 키오스크의 기초 UI를 설계함.

---

## 📸 과제 1: 기본 UI 배치 및 메뉴 선택 기능 구현

| ![실행화면](img/Main1.png) | ![실행화면](img/checkbox1.png) |
 ![실행화면](img/listandtotal1.png) 

**✅ 과제 내용**
- 키오스크의 메인 테마에 맞춘 배경색(`MintCream`) 및 제목 Label 설정
- `GroupBox`를 활용하여 햄버거 메뉴 섹션을 분리하고 `RadioButton` 배치
- 각 메뉴에 해당하는 `PictureBox` 이미지를 연결하여 시각적 정보 제공

**💡 상세 구현 내용**
- **메뉴 그룹화:** `groupMenu`라는 이름의 GroupBox를 배치하여 햄버거 종류(햄버거, 불고기버거, 치킨버거)를 관리하였습니다. RadioButton의 `Name` 속성을 `rdoHamBurger`, `rdoBulgogiBurger`, `rdoChickenBurger`로 설정하여 코드 가공성을 높였습니다.

- **이미지 매칭:** 각 라디오버튼 상단에 `picHamBurger`, `picBulGogi` 등 PictureBox를 배치하고 `SizeMode`를 `StretchImage`나 `Zoom`으로 설정하여 정해진 영역 내에 이미지가 깔끔하게 표시되도록 구현하였습니다.

- **기초 로직 준비:** 버튼 클릭 시 어떤 라디오버튼이 `.Checked == true` 상태인지 판별할 수 있도록 이벤트 핸들러(`btnOrder_Click`) 내부에 분기 처리 구조를 설계하였습니다.

**분석 및 학습 포인트**
- **라디오 버튼과 그룹:**  RadioButton은 같은 컨테이너 내에서 하나를 선택하면 나머지가 자동으로 해제되는 특성이 있습니다. 이를 통해 주문 시스템에서 '메인 메뉴' 로직을 간단하게 구현할 수 있었습니다.



---

