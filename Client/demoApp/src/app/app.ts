import { HttpClient } from '@angular/common/http';
import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

interface Product {
  id: number;
  name: string;
  price: number;
}

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  private urlApi = 'http://localhost:5184/api/product/products';
  protected readonly products = signal<Product[]>([]);

  protected readonly title = signal('demoApp');

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getProducts();
  }

  getProducts() {
    this.http.get(this.urlApi).subscribe((products) => {
      this.products.set(products as Product[]);
      console.log(products);
    });
  }



}
