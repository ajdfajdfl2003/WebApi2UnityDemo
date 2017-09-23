Feature: ProductApi
	In order to avoid silly mistakes
	As a idiot
	I want to be told the api is ok nor not.

	Scenario: 功能ProductApi，AlocationProducts查詢Get，成功取得資料。
		Given 預計資料表應有
		| Id | Name   | Price |
		| 1  | Apple  | 30    |
		| 3  | Guava  | 50    |
		When 呼叫查詢AlocationProducts的Get
		Then 查詢Get結果應為Ok，結果應為
		| Id | Name   | Price |
		| 1  | Apple  | 30    |
		| 3  | Guava  | 50    |