Feature: ProductRepo
	In order to avoid silly mistakes
	As a db manager
	I want to be told which db i should use.

	Scenario: 功能ProductRepo，GetAll查詢，取得資料。
		Given 連接Db的名字 ProductDb01
		And 預計 Product 資料表應有
		| Id | Name   | Price |
		| 1  | Apple  | 30    |
		| 2  | Orange | 40    |
		| 3  | Guava  | 50    |
		When 呼叫GetAll
		Then 結果應為
		| Id | Name   | Price |
		| 1  | Apple  | 30    |
		| 2  | Orange | 40    |
		| 3  | Guava  | 50    |