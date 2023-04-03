FROM golang:alpine AS builder

WORKDIR /app

COPY go.mod go.sum ./

RUN go mod download

COPY . .

RUN go build -o build/fizzbuzz

FROM scratch

COPY --from=builder /app/build/fizzbuzz /fizzbuzz
COPY --from=builder /app/templates /templates

CMD ["./fizzbuzz", "serve"]