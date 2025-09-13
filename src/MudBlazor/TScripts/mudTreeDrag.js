export function getDropPosition(element, mouseY) {
    const rect = element.getBoundingClientRect();
    const offsetY = mouseY - rect.top;
    const third = rect.height / 3;

    if (offsetY >= 0 && offsetY <= third) return 'before';
    else if (offsetY >= third && offsetY <= 2 * third) return 'child';
    return 'after';
}