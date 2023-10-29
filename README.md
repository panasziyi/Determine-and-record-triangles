# 作業2：判斷並記錄三角形

請設計一個視窗程式，讓使用者輸入三個數值後，判斷此三個數值是否可以構成三角形。你的程式必須滿足以下要求。
三個TextBox來輸入三個邊長，如果某個輸入邊長不是數值(使用Double.TryParse方法)，或是數值小於0則顯示訊息方塊要求使用者重新輸入。
一個Label元件用來呈現此三個數值是否可以構成三角形。舉例如果三邊長5,6,7可構成三角形，則將此Label背景顏色設為綠色，並顯示"邊長5, 6, 7可構成三角形；否則將Label背景顏色設為紅色，並顯示"邊長3,4,8不可構成三角形"。
設計一個Triangle類別來儲存三角形資訊。屬性為三個double變數用來儲存三邊長資訊，以及一個bool變數用來儲存此三邊長是否可構成三角形。以List<Triangle>型態來產生triangles物件，用以儲存所有判斷的三角形，並將所有的測試過程顯示於一個TextBlock元件上。
請將你的cs, xaml與執行畫面放在作業內，並以你的學號當作pdf檔名繳交作業。