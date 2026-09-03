To reproduce the problem, execute the following query

```graphql
query {
  products {
    nodes {
      id
      ...ProductItemFragment @defer(label: "ProductsQuery$defer$productDetails")
    }
  }
}

fragment ProductItemFragment on Product {
  productNumber
}
```

With headers:
- `Accept`: `application/json, multipart/mixed; incrementalSpec=v0.1`
