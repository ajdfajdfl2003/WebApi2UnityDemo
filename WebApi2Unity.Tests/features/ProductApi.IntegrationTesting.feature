Feature: ProductApiIntegrationTesting
	In order to avoid silly mistakes
	As a idiot
	I want to be told the api is ok nor not.

	Scenario: 功能ProductApiIntegrationTesting，BlocationProducts查詢Get，成功取得資料。
		Given 建立 http://localhost:33834/api/BProducts 測試物件
		And 預計 ProductDb02Context 的 Product 資料表應有
		| Id | Name   | Price |
		| 2  | Orange | 40    |
		| 3  | Guava  | 50    |
		When 開始查詢
		Then 查詢Get結果應為Ok
		And 結果應為
		| Id | Name   | Price |
		| 2  | Orange | 40.0000    |
		| 3  | Guava  | 50.0000    |

	Scenario: 功能ProductApiIntegrationTesting，AlocationProducts查詢Get，成功取得資料。
		Given 建立 http://localhost:33834/api/AProducts 測試物件
		And 預計 ProductDb01Context 的 Product 資料表應有
		| Id | Name   | Price |
		| 1  | Apple  | 30    |
		| 3  | Guava  | 50   |
		When 開始查詢
		Then 查詢Get結果應為Ok
		And 結果應為
		| Id | Name   | Price |
		| 1  | Apple  | 30.0000   |
		| 3  | Guava  | 50.0000    |