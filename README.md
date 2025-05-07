# CalculatorApp

# **프로젝트 발표**

**일자**: 5/8 (목) 오전 10시~**진행 방식**: **시연** + **설명** (기능, 기술, 설계 위주)

### 🤷‍♂️ **발표 시 설명할 내용:**

1. **구현한 기능** 소개
    - Class
        
        
        | StandardVersion.cs | 표준 계산기 |
        | --- | --- |
        | Operation.cs | 표준 계산기 연산 모음집 |
        | TempConverter.cs | 온도 변환 계산기 |
        | TempConverterLogin.cs | 온도 변환 연산 모음집 |
    - 기능
        - 기본 UI Design
        - 버튼 누를 때마다 Text창에 출력
        - 입력된 수식 분석 (parse)
        - 연산 수행
        - Button 눌러 Panel 전환 (표준 계산기⭤ 온도 변환 계산기)
        - 온도 변환
    
2. **설계 방법** 및 **사용한 기술** 설명
    - 설계 방법 (데이터 전송되는 방식 / 어떤 이벤트 쓰였는지)
        1. Build & Run → Program.cs → Form1.cs
        2. Form1.cs 내부에 추가한 Panel에 StandardVersion.cs (표준계산기) 출력
        3. 상단의 Toggle Button 클릭 시 Panel의 class가 TempConverter.cs로 전환됨 (반대로도 동작)
    - 사용한 기술
        - Panel 이용한 UserControl 상태 관리
        - Regex class 활용한 수식 쪼개기 ( a + b 를 a, +, b로 쪼개기)
        - Math class 내장 메소드 활용 (Pow, Sqrt 등)
        - 버튼 이벤트 통합 (버튼마다 이벤트 생성 X)
        - TryParse 이용한 예외 처리
    
3. **코드의 주요 부분** 설명 (핵심 로직)
    - Panel 전환 이벤트
        
        
        ![image.png](attachment:d0df2acf-bce6-4761-9c00-887e48882b83:image.png)
        
        초기 Form1.cs 실행 시 표준 계산기 객체 만들어 Panel에 띄움
        
        ![image.png](attachment:53a04486-ea3f-4084-baef-939edbbc6fe6:image.png)
        
        ![image.png](attachment:1a1cb550-d1c9-4e53-b41e-d892bc6d65d8:image.png)
        
        버튼 클릭 시 ‘온도 변환 계산기’로 Panel의 내용 전환
        
        ![image.png](attachment:f9d4500d-cb5c-47a0-a804-40b01fcc79b2:image.png)
        
    - 버튼 클릭 시 이벤트
        
        
        ![image.png](attachment:4ef1a9bc-2310-408a-90b6-8db03f4e2153:image.png)
        
        이와 비슷한 맥락의 이벤트 메소드 많음.
        연산자가 두번 입력되는 경우 뒤에 넣은 연산자를 변경하거나 같은 기호가 추가되지 않게 예외처리
        
        ![image.png](attachment:4c608336-2e61-4933-8912-aedbafcb2cdf:image.png)
        
    - =(계산 버튼) 누를 시 이벤트(사칙연산)
        
        
        ![image.png](attachment:dce409f2-7e66-4ccb-8a93-fe23b8f6df46:image.png)
        
        ![image.png](attachment:c9036929-74d5-40fd-ac11-6b75ce9d5209:image.png)
        
        - 문자열을  쪼개서 문자열 배열에 저장
        - a 와 b를 splited배열에서 차례대로 저
        - op에 MatchCollection으로 찾은 연산자를 저장
        - 결과 출력
        
    - CE 누를 시 이벤트
        
        ![image.png](attachment:2edd68d7-ffaf-4a1b-b8b3-7c0527a08185:image.png)
        
        조건문을 통해 문자열 배열의 길이를 조건으로 splited[0], 즉 int a를 다시 꺼내오는 이벤트
        
        
        
    
4. **질의응답**
