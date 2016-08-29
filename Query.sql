select sl.ProductId, (select count(CustomerId) 
						from (select CustomerId, (select top 1 ProductId from [Sales]
													where CustomerId = s.CustomerId
													order by DateCreated
												) as FirstProduct 
								from [Sales] s
								group by CustomerId
							) CustomerFirstProduct
						where CustomerFirstProduct.FirstProduct = sl.ProductId
					) FirstСustomerPurchase from [Sales] sl
group by sl.ProductId