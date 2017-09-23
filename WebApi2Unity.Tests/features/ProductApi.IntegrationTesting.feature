Feature: ProductApiIntegrationTesting
	In order to avoid silly mistakes
	As a idiot
	I want to be told the api is ok nor not.

	Scenario: 功能ProductApiIntegrationTesting，AlocationProducts查詢Get，成功取得資料。
		Given 建立 http://localhost:33834/api/AProducts 測試物件
		And 預計 Product 資料表應有
		| Id | Name   | Price |
		| 1  | Apple  | 30    |
		| 3  | Guava  | 50   |
		When 呼叫查詢AProducts的Get
		Then 查詢Get結果應為Ok
		And 結果應為
		| Id | Name   | Price |
		| 1  | Apple  | 30.0000   |
		| 3  | Guava  | 50.0000    |