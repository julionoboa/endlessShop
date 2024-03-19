import { EndlessShopTemplatePage } from './app.po';

describe('EndlessShop App', function() {
  let page: EndlessShopTemplatePage;

  beforeEach(() => {
    page = new EndlessShopTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
